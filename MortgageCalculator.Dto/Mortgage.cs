using System;

namespace MortgageCalculator.Dto
{
    public class Mortgage
    {
        private MortgageType _mortgageType;
        private InterestRepayment _interestRepayment;
        public int MortgageId { get; set; }
        public string Name { get; set; }

        public MortgageType MortgageType
        {
            get { return _mortgageType; }
            set
            {
                _mortgageType = value;
                MortgageTypeName = Enum.GetName(typeof(MortgageType), _mortgageType);
            }
        }

        public string MortgageTypeName { get; set; }
        public string InterestTypeName { get; set; }

        public InterestRepayment InterestRepayment
        {
            get
            {
                return _interestRepayment;
            }
            set
            {
                _interestRepayment = value;
                InterestTypeName = Enum.GetName(typeof(InterestRepayment), _interestRepayment);
            }
        }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public int TermsInMonths { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
        public Guid SchemaIdentifier { get; internal set; }
        public decimal InterestRate { get; set; }
    }

    public enum MortgageType
    {
        Variable,
        Fixed
    }

    public enum InterestRepayment
    {
        InterestOnly,
        PrincipalAndInterest
    }
}
