export class Event {
  productId: number;
  name: string;
  description: string;
  eventDate: Date;
  location: string;
  ageMin: number;
  categoryId: number;
  companyId: number;
  price: number;
  createdAt: Date;

  constructor(
    productId: number,
    name: string,
    description: string,
    eventDate: Date,
    location: string,
    ageMin: number,
    categoryId: number,
    companyId: number,
    price: number,
    createdAt: Date
  ) {
    this.productId = productId;
    this.name = name;
    this.description = description;
    this.eventDate = eventDate;
    this.location = location;
    this.ageMin = ageMin;
    this.categoryId = categoryId;
    this.companyId = companyId;
    this.price = price;
    this.createdAt = createdAt;
  }
}

