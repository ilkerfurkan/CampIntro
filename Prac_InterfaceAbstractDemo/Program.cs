using Prac_InterfaceAbstractDemo;
using Prac_InterfaceAbstractDemo.Abstract;
using Prac_InterfaceAbstractDemo.Concrete;
using Prac_InterfaceAbstractDemo.Entities;
using Prac_InterfaceAbstractDemo.Adapters;
using MernisServiceReference;

// Kahve dükkanları için müşteri yönetimi yapan bir sistem yazılacak.
// Starbucks ve Nero firmaları için çalışıyoruz.
// İki firma da müşterilerini veritabanına kaydetmek istiyor.
// Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor. Nero istemiyor.
// Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.

BaseCustomerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 10, 18), FirstName = "İlker Furkan", LastName = "Şahin", IdentityNumber = "12345678910" });
