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

## 📫 Bog‘lanish uchun:
<div align="center">
  <a href="https://t.me/aestdile"><img src="https://img.shields.io/badge/Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white" /></a>
  <a href="https://github.com/aestdile"><img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" /></a>
  <a href="https://leetcode.com/aestdile"><img src="https://img.shields.io/badge/LeetCode-FFA116?style=for-the-badge&logo=leetcode&logoColor=black" /></a>
  <a href="https://linkedin.com/in/aestdile"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" /></a>
  <a href="https://youtube.com/@aestdile"><img src="https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white" /></a>
  <a href="https://instagram.com/aestdile"><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" /></a>
  <a href="https://facebook.com/aestdile"><img src="https://img.shields.io/badge/Facebook-1877F2?style=for-the-badge&logo=facebook&logoColor=white" /></a>
  <a href="mailto:aestdile@gmail.com"><img src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white" /></a>
</div>
