namespace PivotTableBindToData.Data {
    public class PivotRow {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}
