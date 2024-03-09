namespace FFSolution.Models
{
    [MetadataType(typeof(CommodityMetaData))]
    public partial class Commodity
    {
    }
    public partial class CommodityMetaData
    {
        public int CommodityID { get; set; }

        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }

        [System.ComponentModel.DisplayName("Commodity Name")]
        public string CommodityName { get; set; }

        [System.ComponentModel.DisplayName("Description")]
        public string CommodityDescription { get; set; }

        public virtual ICollection<Tran> Tran { get; set; }
    }
}
