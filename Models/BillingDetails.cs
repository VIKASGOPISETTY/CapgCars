namespace CAR_RENTAL_SERVICE.Models
{
    public class BillingDetails
    {
        public string BillId {get; set;}

        public string BillDate {get; set;}

        public string BillStatus {get; set;}

        public int DiscountAmount {get; set;}

        public int TotalAmount {get; set;}

        public int TaxAmount {get; set;}

        public string BookingId {get; set;}

        public int TotalLateFee {get; set;}

        
    }
}