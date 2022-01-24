namespace CAR_RENTAL_SERVICE.Models
{
    public class BookingDetails
    {
        public string BookingId {get; set;}
        public string FromDateTime {get; set;}
        public string ReturnDateTime{get; set;}
        public int Amount {get; set;}
        public string BookingStatus{get; set;}
        public string PickupLocation{get; set;}

        public string DropLocation{get; set;}
        public string RegisterNum{get; set;}
        public string DlNumber{get; set;}
        public string INSCode{get; set;}
        public string ActRetDateTime{get; set;}
        public string DiscountCode{get; set;}
        
    }
}
