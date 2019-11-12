using System;
using System.Collections;
using System.Collections.Generic;

namespace Example_06.ChainOfResponsibility
{
    public enum CurrencyType
    {
        Eur,
        Dollar,
        Ruble
    }

    public interface IBanknote
    {
        CurrencyType Currency { get; }
        string Value { get; }
    }

    public class Bancomat
    {
        private readonly BanknoteHandler _handler;


        public Bancomat()
        {
            _handler = new TenRubleHandler(null);
            _handler = new TenDollarHandler(_handler);
            _handler = new FiftyDollarHandler(_handler);
            _handler = new HundredDollarHandler(_handler);
        }

        public bool Validate(string banknote)
        {
            return _handler.Validate(banknote);
        }

        public Dictionary<string, int> CashOut(int sum, string currency)
        {
            Dictionary<string, int> moneyToCashOut = new Dictionary<string, int>() {
                { "100$", 0 },
                { "50$" , 0 },
                { "10$", 0 },
                { "10RUB", 0 }
            };
            return _handler.CashOut(sum, currency, moneyToCashOut);
        }
    }

    public abstract class BanknoteHandler
    {
        private readonly BanknoteHandler _nextHandler;

        protected BanknoteHandler(BanknoteHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual bool Validate(string banknote)
        {
            return _nextHandler != null && _nextHandler.Validate(banknote);
        }

        public virtual Dictionary<string, int> CashOut(int sum, string currency, Dictionary<string, int> moneyToCashOut)
        {
            if (_nextHandler == null && sum != 0)
            {
                Console.WriteLine($"Осталось на балансе: { sum } {currency}");
                return moneyToCashOut;
            }
            else if ( _nextHandler == null )
            {
                return moneyToCashOut;
            }
            else
            {
                return _nextHandler.CashOut(sum, currency, moneyToCashOut);
            }
        }
    }

    public class TenRubleHandler : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            if (banknote.Equals("10 Рублей"))
            {
                return true;
            }
            return base.Validate(banknote);
        }

        public override Dictionary<string, int> CashOut(int sum, string currency, Dictionary<string, int> moneyToCashOut)
        {
            if ( currency == "RUB" && sum >= 10)
            {
                moneyToCashOut["10RUB"] += 1;
                return CashOut(sum - 10, currency, moneyToCashOut);
            }
            return base.CashOut(sum, currency, moneyToCashOut);
        }

        public TenRubleHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }

    public abstract class DollarHandlerBase : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            if (banknote.Equals($"{Value}$"))
            {
                return true;
            }
            return base.Validate(banknote);
        }

        public override Dictionary<string, int> CashOut(int sum, string currency, Dictionary<string, int> moneyToCashOut)
        {
            if ( currency == "$" && sum >= Value)
            {
                moneyToCashOut[$"{Value}$"] += 1;
                return CashOut(sum - Value, currency, moneyToCashOut);
            }
            return base.CashOut(sum, currency, moneyToCashOut);
        }

        protected abstract int Value { get; }

        protected DollarHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }

    public class HundredDollarHandler : DollarHandlerBase
    {
        protected override int Value => 100;

        public HundredDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }

    public class FiftyDollarHandler : DollarHandlerBase
    {
        protected override int Value => 50;

        public FiftyDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }

    public class TenDollarHandler : DollarHandlerBase
    {
        protected override int Value => 10;

        public TenDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}