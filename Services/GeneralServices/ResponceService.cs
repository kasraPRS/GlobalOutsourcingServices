namespace GlobalOutsourcingServices.Services.GeneralServices
{
    public class ResponceService<T>
    {
        public bool Success {  get; set; }

        public required string Message { get; set; }

        public required T Data { get; set; }
    }
}
