namespace Models.Domain.AppKeys
{
    public class AppKeys
    {
        public string StripeConfigurationApiKey { get; set; }
        public string Domain { get; set; }
        public string DomainName { get; set; }
        public string DomainEmail { get; set; }
        public string SendGridAppKey { get; set; }
        public string AzureStorage { get; set; }
        public string DefaultConnection { get; set; }
    }
}