# WebApp

# # 08.10.2021

Database için tablolar ve ilişkileri oluşturuldu.
Database'in üzerine sağ tık -> Tasks -> Script next next denerek script desktop'a kaydedildi.
Üyerlerle paylaşılmak üzere Github'a eklendi.
Diğer üyeler bunu indirip Microsoft SQL Management System'da öncesinde create new Database "DB_LIBRARY" yaparak ve daha sonrasında ctrl+a yapıp execute'e basarak çalıştırabilirler.


NOT: Code -> open with GitHub Desktop diyerek desktop üzerinden kodlama yapılabilir. Daha sonra değişiklikler açıklaması yapılarak commit edilir ve push origin denilerek ortak alana aktarılır.

# # 10.10.2021

Kategori bölümü tamamlandı. Kategori ekleme, güncelleme ve silme kısımları ayarlandı. Tasarım düzenlemesi gerekli.\
Tedbir amacli categoryPart branch'ı acip oraya yükledim çünkü veri tabanı bağlantısında web.config içerisinde connectionStrings kısmında kalın yazılarla belirtilen yere herkesin kendi local bilgisayar adını yazarak öyle bağlanmayı denemesi lazım çözüm olmazsa başka bir formül bulmamız lazım.\
!!Database ismi ve tabloları burada paylaştığımız script olmalı farklı bir isim ve tablo yapısında sorun çıkabilir.!!

### web.config içerisindeki bölüm
  <connectionStrings
    <add name="DB_LIBRARYEntities" connectionString="metadata=res://*/Models.Entity.Model1.csdl|res://*/Models.Entity.Model1.ssdl|res://*/Models.Entity.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=  **DESKTOP-UE5II9K**  ;initial catalog=DB_LIBRARY;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient"
  </connectionStrings>

# # 11.10.2021

NOT: Eğer kodu visual studio ile actığınızda sağ tarafta references, properties vs görünmüyorsa proje, dosya olarak açılmış demektir. Çalışan bir proje olarak açmak için altta bulunan LibraryManagementSystem.sln'e tıklayabilirsiniz.
Eğer hala Model ksımının altında entity dosyası görünmüyorsa github desktop üzerinden yukarıda da yazıldığı gibi current branch'i categoryPart yapıp fetch origin diyerek gelmesini sağlayabilirsiniz.
Eğer projeye bir şey eklemek istediğinizde aradığınız şeyi bulamıyorsanız, -create new project en altta -install more tools and features diyerek .Net ile ilgili her şeyi işaretleyip -update tıklayın.
