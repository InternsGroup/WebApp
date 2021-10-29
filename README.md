# WebApp

# # 08.10.2021

* Database için tablolar ve ilişkileri oluşturuldu.
* Database'in üzerine sağ tık -> Tasks -> Script next next denerek script desktop'a kaydedildi.
* Üyerlerle paylaşılmak üzere Github'a eklendi.
* Diğer üyeler bunu indirip Microsoft SQL Management System'da öncesinde create new Database "DB_LIBRARY" yaparak ve daha sonrasında ctrl+a yapıp execute'e basarak çalıştırabilirler.


* NOT: Code -> open with GitHub Desktop diyerek desktop üzerinden kodlama yapılabilir. Daha sonra değişiklikler açıklaması yapılarak commit edilir ve push origin denilerek ortak alana aktarılır.

# # 10.10.2021

* Kategori bölümü tamamlandı. Kategori ekleme, güncelleme ve silme kısımları ayarlandı. Tasarım düzenlemesi gerekli.\
* Tedbir amacli categoryPart branch'ı acip oraya yükledim çünkü veri tabanı bağlantısında web.config içerisinde connectionStrings kısmında kalın yazılarla belirtilen yere herkesin kendi server'ının properties'ine bakıp adını kopyalayıp oraya yapıştırması ve öyle bağlanmayı denemesi lazım.\
!!Database ismi ve tabloları burada paylaştığımız script olmalı farklı bir isim ve tablo yapısında sorun çıkabilir.!!

### web.config içerisindeki bölüm
  <connectionStrings
    <add name="DB_LIBRARYEntities" connectionString="metadata=res://*/Models.Entity.Model1.csdl|res://*/Models.Entity.Model1.ssdl|res://*/Models.Entity.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=  **DESKTOP-UE5II9K**  ;initial catalog=DB_LIBRARY;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient"
  </connectionStrings>

# # 11.10.2021

* NOT1 : Eğer kodu visual studio ile actığınızda sağ tarafta references, properties vs görünmüyorsa proje, dosya olarak açılmış demektir. Çalışan bir proje olarak açmak için altta bulunan LibraryManagementSystem.sln'e tıklayabilirsiniz.
* NOT2 : Eğer hala Model ksımının altında entity dosyası görünmüyorsa github desktop üzerinden yukarıda da yazıldığı gibi current branch'i categoryPart yapıp fetch origin diyerek gelmesini sağlayabilirsiniz.
* NOT3 : Eğer projeye bir şey eklemek istediğinizde aradığınız şeyi bulamıyorsanız, -create new project en altta -install more tools and features diyerek .Net ile ilgili her şeyi işaretleyip -update tıklayın.
* NOT4 : Eğer projeyi çalıştırdığınızda "System.NullReferenceException" veriyorsa App_Start -> BundleConfig.cs ->  bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js")); bu kod yerine -> bundles.Add(new Bundle("~/bundles/mybundle").Include(
        "~/Scripts/bootstrap.js")); bu kodu yazmalısınız.\
        
Kategori tablosu güzelleştirildi.

# # 19.10.2021

* Kitap bölümü tamamlandı

# # 21.10.2021

* Kitap bölümüne arama çubuğu eklendi --> diğer bölümlere de aynı şekilde ekleyebiliriz\
* Personel ekleme, güncelleme, silme kısmı ayarlandı\
* Üye ekleme, güncelleme, silme ve input validation kısımları tamamlandı\
* Üye tablosu için sayfalama ayarı yapıldı (yani her sayfada tablo içinde belirli sayıda üye gösteriliyor) --> diger bölümlere de eklenebilir, farklı tipleri kullanılabilir 

# # 29.10.2021

* Kitap ödünç verme ve alma bölümleri tamamlandı.
* Chat kısmını eklemek için işimize yarayabilecek linkler 
   ** https://pusher.com/tutorials/chat-aspnet/
   
