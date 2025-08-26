siam siam siam suiam
# Grocery Shop Management System

This repository contains the source code for a comprehensive Grocery Shop Management System built with Windows Forms (.NET Framework) and Oracle Database.

## Project Overview
The system streamlines and automates grocery shop operations, providing role-based access and features for Admin, Manager, Cashier, and Salesman.

---

## Roles & Features

### 1. Admin (Roshni)
1. Login
2. Logout
3. Create/Edit/Delete Users
4. Assign Roles (Admin, Manager, Cashier, Customer/Staff)
5. Change system settings (tax rate, discount rules, shop info, etc.)
6. Manage Products (add/edit/delete)
7. Manage Categories
8. Manage Suppliers
9. Full Database backup & restore
10. Generate Profit/Loss Reports
11. Approve high-level changes (e.g., delete bulk records, reset system)
12. View all system activity logs (who logged in/out, operations done)

### 2. Manager (Siam)
1. Login
2. Logout
3. Manage Stock levels (add/update inventory, handle damaged/expired stock)
4. Create and approve Purchase Orders (from suppliers)
5. Approve Discounts & Promotions
6. Manage Returns/Exchanges requests
7. View and generate Daily Sales Reports
8. View and generate Monthly/Yearly Reports
9. Monitor Cashier performance (sales per cashier)
10. Assign Staff shifts / scheduling
11. Handle Supplier payments & dues
12. Print/Export Reports (PDF/Excel)

### 3. Cashier (Arif)
1. Login
2. Logout
3. Process sales (POS)
4. Scan products to cart
5. Apply discounts (if allowed)
6. Print invoices
7. Accept payments (cash/card/mobile)
8. Process returns/exchanges
9. View daily sales summary
10. Search product by barcode/name
11. Check stock (read-only)
12. Hold/resume sales

### 4. Salesman (Hacin)
1. Login
2. Logout
3. View products
4. Search products
5. Place orders
6. Add to cart
7. View order history
8. Track order status
9. Manage profile
10. Request returns/exchanges
11. Give feedback/reviews
12. Receive offers/notifications

---

## Technology Stack
- **Frontend**: .NET Windows Forms
- **Backend**: C# (.NET Framework)
- **Database**: Oracle Database
- **ORM**: Oracle Data Provider for .NET (ODP.NET)

## Project Setup
1. **Prerequisites**
   - Visual Studio (2019 or later recommended)
   - .NET Framework 4.7.2 or higher
   - Oracle Database (11g or higher)
   - Oracle Data Provider for .NET
2. **Database Configuration**
   - Create a new Oracle database or use an existing one
   - Run the SQL scripts in the `/Database` folder to set up the schema
   - Update the connection string in the `App.config` file
3. **Build & Run**
   - Open the solution in Visual Studio
   - Restore NuGet packages
   - Build the solution
   - Run the application

## Project Structure
- `/Forms` - Contains all Windows Forms
- `/Models` - Data models/entities
- `/Services` - Business logic implementation
- `/Repositories` - Database access layer
- `/Utils` - Helper classes and utilities
- `/Resources` - Images and other resources

## Team Members
| Name | ID | Role |
|------|----|------|
| Siam Hossain | 24-56637-1 | Manager |
| Sumaiya Akter Roshni | 23-5327-3 | Admin |
| Md Arif Mahmud Oyion | 24-56305-1 | Cashier |
| Hacin Mijbahur Rahman | 23-55589-3 | Salesman |

## Screenshots
![Screenshot 1](path/to/screenshot1.png)
*Caption for Screenshot 1*

![Screenshot 2](path/to/screenshot2.png)
*Caption for Screenshot 2*

## Future Improvements
- [Improvement 1]
- [Improvement 2]
- [Improvement 3]

## License
This project is for educational purposes.