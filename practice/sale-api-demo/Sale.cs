public class Sale
{
    private static int _nextId = 0;
    public int Id {get; private set;}
    public DateTime SaleDate {get; private set;}
    public DateTime CreatedAt {get; private set;}
    private List<SaleItem> _saleItems {get; set;} = new();
    public IReadOnlyCollection<SaleItem> SaleItems => _saleItems;
    public bool IsClosed {get; private set;} = false;
    public int TransactionNumber {get; private set;} = 0;
    public Sale (DateTime saleDate)
    {
        GuardSale(saleDate);
        _nextId ++;
        Id = _nextId;
        SaleDate = saleDate;
        CreatedAt = DateTime.Now;
    }
    public void AddSaleItem (SaleItem saleItem)
    {
        GuardClosedSale();
        if (saleItem == null)
        {
            throw new ArgumentNullException(nameof(saleItem), "Item to be added to sale must be provided");
        }
        if (saleItem.SaleId != default)
        {
            throw new InvalidOperationException("Item to be added is already assigned to another sale.");
        }
        TransactionNumber ++;
        saleItem.AssignToSale(Id, TransactionNumber);
        _saleItems.Add(saleItem);
    }
    public void RemoveSaleItem (SaleItem saleItem)
    {
        GuardClosedSale();
        if (saleItem == null)
        {
            throw new ArgumentNullException(nameof(saleItem), "Item to be removed from sale must be provided");
        }
        if (saleItem.SaleId != Id)
        {
            throw new InvalidOperationException("Item provided is not assigned to this sale.");
        }
        var foundSaleItem = _saleItems.Find(si => si.TransactionNumber == saleItem.TransactionNumber);
        if (foundSaleItem == null)
        {
            throw new KeyNotFoundException("No match found for removal of sale item.");
        }
        foundSaleItem.RemoveFromSale();
        _saleItems.Remove(foundSaleItem);
        
    }
    public void GuardSale (DateTime saleDate)
    {
        if (saleDate == default)
        {
            throw new ArgumentException("Date of sale must be provided", nameof(saleDate));
        }
        if (saleDate > DateTime.Now)
        {
            throw new ArgumentException("Date of sale cannot be in the future", nameof(saleDate));
        }
    }
    public void GuardClosedSale ()
    {
        if (IsClosed)
        {
            throw new InvalidOperationException("Sale is already closed.");
        }
    }
    public void CloseSale()
    {
        GuardClosedSale();
        if (_saleItems.Count == 0)
        {
            throw new InvalidOperationException("Add an item to sale before closing.");
        }
        IsClosed = true;
    }
}