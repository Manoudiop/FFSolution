namespace FFSolution.Models
{
    public class ProfitViewModel
    {
        public ProfitViewModel(int id)
        {
            using (FFAdminDBEntities db = new FFAdminDBEntities())
            {
                this.TranId = id;
                this.BLNo = db.Tran.FirstOrDefault(s => s.TranID == id).BLNo;
                this.Profits = db.TranProfit.Where(x => x.TranID == id).Include(t => t.Currency).ToList();
                this.Totals = db.TranTotals.Where(x => x.TranID == id).Include(t => t.Currency).ToList();
            }
        }
        public int TranId { get; set; }

        public string BLNo { get; set; }

        public List<TranTotals> Totals { get; set; }
        public List<TranProfit> Profits { get; set; }
    }
}