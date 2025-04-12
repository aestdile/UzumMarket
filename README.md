# 🛒 Uzum Market - OOP Based CRUD Console App (C#)

**Uzum Market** — bu C# tilida yozilgan **Object-Oriented Programming (OOP)** asosidagi to‘liq **CRUD tizimi**, unda Manager, Seller va Customer rollari o‘zaro aloqada ishlaydi.

---

## 🧱 Arxitektura

```
UzumMarket/
│
├── Models/
│   └── Roles/
│       ├── Manager.cs
│       ├── Seller.cs
│       └── Customer.cs
│
│   └── Product.cs
│   └── Order.cs
│
├── Services/
│   └── IServices/
│       ├── IManagerService.cs
│       ├── ISellerService.cs
│       ├── ICustomerService.cs
│       ├── IProductService.cs
│       └── IOrderService.cs
│
│   └── ManagerService.cs
│   └── SellerService.cs
│   └── CustomerService.cs
│   └── ProductService.cs
│   └── OrderService.cs
│
├── Program.cs
└── README.md
```

---

## ⚙️ Rollar va Ularga Tegishli Metodlar

### 👤 **Manager**

- **Auth:**
  - `Register()`, `Login()`
- **Seller Management:**
  - `GetAllSellers()`
  - `Increase/DecreaseSalaryOfSeller()`
  - `UpdatePositionOfSeller()`
  - `DeleteSeller()`
- **Product Management:**
  - `GetAllProducts()`, `DeleteProduct()`
- **Customer Management:**
  - `GetAllCustomers()`, `DeleteCustomer()`
- **Order Management:**
  - `GetAllOrders()`, `DeleteOrder()`

---

### 🧐️ **Seller**

- **Auth:**
  - `Register()`, `Login()`
- **Product Management:**
  - `AddProduct()`, `UpdateProduct()`
  - `GetAllProducts()`, `GetProductById()`, `DeleteProduct()`

---

### 🧑 **Customer**

- **Auth:**
  - `Register()`, `Login()`
- **Order Management:**
  - `GetAllProducts()`
  - `CreateOrder()`, `DeleteOrder()`
  - `Deposit()`

---

## 📦 Modellar: Propertylar

### Manager

- FirstName, LastName, Email, Password

### Seller

- Id, FirstName, LastName, Email, Password, Salary, Position

### Customer

- Id, FirstName, LastName, Age, BirthDate, Gender, Address, Phone, Email, Password, Balance

### Product

- Id, Name, Description, Count, Price, Category, FactoryName, MadeDate, ExpireDate, IsExpired

### Order

- Id, ProductId, Quantity, CreatedAt, Status, PaymentStatus, ShippingAddress

---

## 💡 CRUD Prinsiplari

| Rol      | Create | Read | Update      | Delete |
| -------- | ------ | ---- | ----------- | ------ |
| Manager  | ✅      | ✅    | ✅           | ✅      |
| Seller   | ✅      | ✅    | ✅           | ✅      |
| Customer | ✅      | ✅    | 🔄(Balance) | ✅      |
| Product  | ✅      | ✅    | ✅           | ✅      |
| Order    | ✅      | ✅    | ❌           | ✅      |

---

## 📘 Texnologiyalar

- 🧠 C# (Console Application)
- 📦 OOP: Abstraction, Encapsulation, Inheritance, Polymorphism
- 📂 Ma'lumotlar List orqali saqlanadi *(Json yoki SQL versiyaga kengaytirilishi mumkin)*

---

## 📝 Misol Ko‘rinish (Console UI)

```
Welcome to Uzum Market!

1. Login as Manager
2. Login as Seller
3. Login as Customer
4. Exit

>> 1

-- MANAGER PANEL --
1. Manage Sellers
2. Manage Products
3. Manage Customers
4. Manage Orders
5. Exit
```

---

## 📚 Rekomendatsiya

- `List<T>` bilan boshlang, so‘ng `Json` yoki `SQL` bilan kengaytirish mumkin.
- Loyihani modul tarzida rivojlantiring, interfeyslar orqali mustahkamlashni unutmang.
- Har bir xizmat alohida xizmat klassida bo‘lishi — Clean Architecture tamoyiliga mos.

---

## ✍️ Muallif

**👤 Mukhtor Eshboyev**\
🔗 GitHub: [@aestdile](https://github.com/aestdile)\
📌 *"When you finish this project, upload it to GitHub and send me the repository link, I'll wait for it!"*

---

> Ushbu loyiha ta’limiy va real dunyo tizimlarida CRUD tizimlar qanday ishlashini o‘rganish uchun mo‘ljallangan.

