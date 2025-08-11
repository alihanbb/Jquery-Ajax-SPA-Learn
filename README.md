# jQuery & ASP.NET Core SPA - Kitap Yönetimi

Bu proje, ASP.NET Core Razor Pages ve jQuery kullanarak modern bir Tek Sayfa Uygulaması (Single Page Application - SPA) geliştirmeyi amaçlayan bir öğrenme ve pratik projesidir. Proje, sayfa yenilemesi olmadan kitaplar üzerinde CRUD (Create, Read, Update, Delete) işlemlerinin nasıl yapılacağını göstermektedir.

## 🚀 Projenin Amacı

Bu projenin temel amacı, geleneksel web uygulamalarına kıyasla daha akıcı ve hızlı bir kullanıcı deneyimi sunan SPA'ların temel prensiplerini anlamaktır. jQuery ve AJAX kullanarak backend ile asenkron veri alışverişi yapmanın ve kullanıcı arayüzünü dinamik olarak güncellemenin pratik bir örneğidir.

## ✨ Özellikler

- **Dinamik Kitap Listeleme:** Kitaplar veritabanından çekilir ve sayfa yenilenmeden bir tablo üzerinde listelenir.
- **Modal ile Kitap Ekleme:** Bootstrap 5 modal penceresi üzerinden yeni kitaplar eklenebilir.
- **Modal ile Kitap Güncelleme:** Mevcut bir kitabın bilgileri yine bir modal pencere üzerinden düzenlenebilir.
- **Kitap Silme:** Kullanıcıdan onay alınarak kitaplar listeden ve veritabanından silinir.
- **Toast Bildirimleri:** Her işlem (ekleme, güncelleme, silme) sonrasında kullanıcıya anlık başarı veya hata bildirimleri gösterilir.
- **Client-Side & Server-Side Validasyon:** Formlara girilen veriler hem frontend (jQuery) hem de backend (Data Annotations) tarafında doğrulanır ve hatalar kullanıcıya gösterilir.
- **Modern ve Duyarlı Arayüz:** Bootstrap 5 kullanılarak modern ve mobil uyumlu bir tasarım oluşturulmuştur.

## 🛠️ Kullanılan Teknolojiler

### Backend
- **ASP.NET Core Razor Pages (.NET 9):** Sunucu taraflı mantık ve sayfa yönetimi için.
- **C#:** Backend programlama dili.
- **Entity Framework Core:** Veritabanı işlemleri için kullanılan ORM (Object-Relational Mapper).
- **In-Memory Database:** Projenin hızlıca çalıştırılabilmesi için geçici bellek-içi veritabanı.
- **Repository & Service Pattern:** Veri erişim ve iş mantığı katmanlarını ayırmak için.
- **ViewModel Pattern:** Frontend ve backend arasında güvenli ve temiz veri transferi için.

### Frontend
- **HTML5 & CSS3:** Sayfanın temel yapısı ve stillendirmesi.
- **Bootstrap 5:** Duyarlı ve modern bir kullanıcı arayüzü oluşturmak için.
- **jQuery:** DOM manipülasyonu ve olay yönetimi için.
- **AJAX:** Sunucu ile asenkron veri alışverişi yapmak için.
- **Bootstrap Icons:** İkon setleri için.

## 🏃‍♂️ Projeyi Çalıştırma

1.  Bu repoyu klonlayın:
    ```bash
    git clone <repo-url>
    ```
2.  Projeyi Visual Studio veya tercih ettiğiniz bir IDE ile açın.
3.  Projeyi başlatmak için `F5` tuşuna basın veya aşağıdaki komutu terminalde çalıştırın:
    ```bash
    dotnet run
    ```
4.  Uygulama başlatıldığında, Entity Framework Core In-Memory Database otomatik olarak oluşturulacaktır. Herhangi bir veritabanı kurulumuna gerek yoktur.
