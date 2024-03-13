namespace Sentinal.Core.Domain.Events
{
    public class RetryFailBackEvent
    {

        #region Properties

        public string? DomainData { get; set; }
        public DateTime TransactionDate { get; }
        public string FailoverSite { get; private set; }
        public string Domain { get; private set; }
        public string Action { get; private set; }

        #endregion

        #region Constructor

        public RetryFailBackEvent(DateTime transactionDate = default)
        {
            TransactionDate = transactionDate;
            FailoverSite = Domain = Action = default!;
        }

        #endregion

        #region Public Static Methods

        public static RetryFailBackEvent Create(string failoverSite, string domain, string action)
        {
            return new RetryFailBackEvent(DateTime.Now)
            {
                Action = action,
                FailoverSite = failoverSite,
                Domain = domain
            };
        }

        #endregion

    }
}
