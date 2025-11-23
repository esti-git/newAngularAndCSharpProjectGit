export class Purchase {
  purchaseId: number;
  customerId: number;
  purchaseDate: Date;
  totalAmount: number;

  constructor(
    purchaseId: number,
    customerId: number,
    purchaseDate: Date,
    totalAmount: number
  ) {
    this.purchaseId = purchaseId;
    this.customerId = customerId;
    this.purchaseDate = purchaseDate;
    this.totalAmount = totalAmount;
  }
}

