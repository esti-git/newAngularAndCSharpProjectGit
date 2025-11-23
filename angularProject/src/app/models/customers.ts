export class Customers {
  customerId: number;
  username: string;
  email: string;
  password: string;
  createdAt: Date;

  constructor(
    customerId: number,
    username: string,
    email: string,
    password: string,
    createdAt: Date
  ) {
    this.customerId = customerId;
    this.username = username;
    this.email = email;
    this.password = password;
    this.createdAt = createdAt;
  }

}
