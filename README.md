# 🚀 MongoDB ile E-Ticaret Sitesi Coza Store
Bu repository, M&Y Yazılım Akademi bünyesinde yaptığım üçüncü proje olan MongoDb ile E-Ticaret Sitesi Coza Store projesini içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

Bu proje, ASP.NET Core 6.0 ve MongoDb altyapısı kullanılarak geliştirilen kullanıcı tabanlı bir e-ticaret uygulamasıdır.

Coza Store, modern e-ticaret ihtiyaçlarını karşılamak üzere ASP.NET Core 6.0 ile geliştirilmiş tam özellikli bir online alışveriş platformudur. Proje, MongoDB NoSQL veritabanı kullanılarak veri yönetimini sağlamakta ve MongoDB.Driver ile MongoDB.Bson kütüphaneleri aracılığıyla veri geçişleri ve sorgulamaları gerçekleştirilmektedir. Sistem, iki ana bölümden oluşmaktadır: Admin Paneli ve Vitrin Paneli. Admin paneli, ürün yönetimi, kategori düzenleme, stok kontrolü ve sipariş takibi gibi işlevlerin merkezidir. Vitrin paneli ise kullanıcıların ürünleri görüntüleyip filtreleyerek alışveriş yapabilecekleri, kullanıcı dostu ve responsive bir ön yüz sağlar. Projede ayrıca ürünlere birden fazla resim ekleme, kategori bazlı filtreleme, kullanıcı geri bildirimleri ve dinamik içerik yönetimi gibi gelişmiş özellikler bulunmaktadır. MongoDB’nin esnek yapısı sayesinde ürün ve kategori ilişkileri ile birlikte çoklu görsel yönetimi kolaylıkla yapılabilmekte, performans ve ölçeklenebilirlik sağlanmaktadır. Bu yapı sayesinde Coza Store, hem modern teknoloji yığınıyla hem de kullanıcı deneyimini ön planda tutan tasarımıyla gerçek bir e-ticaret çözümü sunar.

🗄️ MongoDB ve Veri Tabanı İşlemleri
Projemde ilişkisel veritabanları yerine MongoDB kullandım. MongoDB, doküman tabanlı, NoSQL bir veritabanı olduğu için veriler JSON benzeri BSON formatında depolanır. Bu yapı, esnek ve hızlı veri yönetimi sağlar, özellikle ürün, kategori ve kullanıcı gibi yapıları rahatça modele edebilmek açısından avantajlıdır.

MongoDB Driver Kullanımı
- Projede MongoDB.Driver kütüphanesi ile MongoDB'ye bağlantı kurdum ve CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirdim.
- Ayrıca MongoDB.Bson kütüphanesi BSON formatındaki veri serileştirme ve deseralize işlemlerini kolaylaştırıyor.

Bağlantı ve Koleksiyonlar
- MongoDB bağlantısı MongoClient aracılığıyla sağlanır.
- Veriler, IMongoCollection<T> tipinde koleksiyonlar halinde yönetilir. Örneğin ürünler, kategoriler, ürün resimleri ayrı ayrı koleksiyonlardır.
- Bağlantı bilgileri appsettings.json dosyasından çekilir ve dependency injection (DI) ile servis olarak projeye dahil edilir.

CRUD İşlemleri
- Create: Yeni ürün, kategori veya mesaj gibi veriler InsertOneAsync() veya InsertManyAsync() metotları ile eklenir.
- Read: Veri sorgulamak için Find() veya FindAsync() metotları kullanılır. Filtreleme, sıralama gibi işlemler MongoDB'nin güçlü sorgu diliyle yapılır. Örneğin, bir ürünün ID’sine göre veri çekmek.
- Update: Belirli bir dökümanın alanlarını değiştirmek için UpdateOneAsync() veya ReplaceOneAsync() kullanılır.
- Delete: Veri silmek için DeleteOneAsync() veya DeleteManyAsync() metotları vardır.

Veri Modelleri ve DTO'lar
- MongoDB’deki veriler, C# sınıfları olarak tanımlanır (Entity modeller). Bu modellerde koleksiyonlarda bulunan alanlar property olarak yer alır.
- Veri transferi ve dışa açma için DTO (Data Transfer Object) kullanılır; böylece veri güvenliği ve performans optimize edilir.

Performans ve Ölçeklenebilirlik
- MongoDB'nin NoSQL yapısı sayesinde, ürünler için çoklu resim gibi karmaşık yapılar kolayca yönetilebilir.
- Proje içinde filtreleme, sayfalama gibi işlemler MongoDB sorgularıyla optimize edilir.

Projede admin panelinde kategori, ürün, ürün resmi ve slider işlemleri yapılmaktadır. Vitrin Paneli'nde ise kullanıcı tüm ürünlerimizi kategorilerle filtrelenmiş şekilde görebilir. Uygulama her ne kadar tek katmanlı bir projede geliştirilmiş olsa da, iç yapısında Entity Layer (veritabanı modelleri), Data Access Layer (veri etkileşimi) ve UI Layer (kullanıcı arayüzü) olacak şekilde katmanlı mimari prensipleri uygulanmıştır. Dosya yapısı Entities, DTOs, Services, Models, Controllers, Views ve ViewComponents klasörleriyle organize edilerek SOLID prensiplerine uygun şekilde düzenlenmiştir. 
Arayüz tarafında modern bir tasarım için Bootstrap 5 tercih edilmiş, parçalı yapıların yönetimi ise ViewComponent yapıları ile sağlanmıştır. Bu yönleriyle proje, .NET Core teknolojileriyle kimlik doğrulama sistemleri ve back-end mimarilerinin uygulamalı olarak öğrenilmesi için kapsamlı, yönetilebilir ve geliştirilebilir bir temel sunmaktadır.<br>

Projede genel anlamda 2 bölüm bulunmaktadır.<br>
Admin Paneli: Burada Admin, Kategori, Ürün, Ürün Resmi ve Slider entity'leri ile ilgili CRUD işlemleri yapılmaktadır.<br>
Vitrin Paneli: Burada da misafirlerimiz alış-verişlerini yapmak üzere kategorilerle filtrelenmiş ürünlerimizi görüntüleyebilir.

Kullandığım Teknolojiler <br>
🖥️ ASP.NET Core 6.0 — Modern, hızlı ve güçlü web uygulama framework'ü<br>
🛢️ MongoDB — Esnek ve ölçeklenebilir NoSQL veritabanı<br>
📦 MongoDB.Driver & MongoDB.Bson — MongoDB ile .NET arasında veri transferi ve sorgulama kütüphaneleri<br>
🗂️ Katmanlı yapı: Entities, Services, Models, Controllers, Views<br>
🧩 ViewComponent kullanımı<br>
🖼️ Razor Pages / MVC — Dinamik web sayfa oluşturma<br>
🎨 HTML5, CSS3, JavaScript — Frontend yapısı ve tasarımı<br>
🧰 Entity Mapping & DTOs — Veri transfer nesneleri ve modellerin yönetimi<br>
🔄 AutoMapper — Nesne dönüşümlerini kolaylaştıran araç<br>

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Vitrin Paneli
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_Default_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/uiproduct1.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/uiproduct2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/uiproduct3.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/uiproduct4.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/uiproduct5.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/newsletter.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Admin Paneli
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_Category_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_Slider_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_ProductImage_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_Product_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_Product_CreateProduct.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/ShoppingMongo/blob/cd10322188a3acd7bd0c84da1af4cb7d04e8d9a2/ss/localhost_7027_Product_UpdateProduct.png" alt="image alt">
</div>




