namespace UserApi.Services
{
    public class ServiceResponse<T>
    {
        public bool Success { get; set; } // نشان‌دهنده موفقیت یا شکست
        public required string Message { get; set; } // پیام مربوط به وضعیت
        public required T Data { get; set; } // داده‌ای که به درخواست بر می‌گردد (اگر موجود باشد)
    }
}