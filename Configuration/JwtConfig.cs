namespace GlobalOutsourcingServices.Configuration
{
    public class JwtConfig
    {
        public string Secret { get; set; } = string.Empty;
        public double ExpiryInDays { get; internal set; }
    }
}
