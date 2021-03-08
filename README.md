# ReCarProject - Araç Kiralama Sistemi
![Araç Kiralama](https://img.letgo.com/images/5e/99/87/74/5e9987741eaf8284622e656816d39b49.jpeg?impolicy=img_600_pwa)
<br><br>
 Araç Kiralama Sistemi, (Nitelikli) Yazılım Geliştirici Yetiştirme Kampı'nda yapılan çalışmaları kapsayan bir projedir.
 <br><br>
Proje, back-end arayüzde sunucu tarafından gerçekleştirilen C# dilinde, katmanlı yazılım kurumsal mimari yapısı, SOLID yazılım prensipleri, Web API, EntityFrameWork yapısı ile geliştirilmiştir. JWT entegrasyonu; Transaction, Cache, Validation ve Performance aspectlerinin implementasyonları gerçekleştirilmiş olup Validation için FluentValidation desteği, IoC için Autofac desteği eklenmiştir.
 <br><br>
## :card_index_dividers: Layers
### :file_folder: Entities Layer
Projede kullanılacak veritabanı nesnelerini tutmak için oluşturulan katmandır.<br>
İki alt klasörden oluşmaktadır. `Abstarct` klasörü soyut nesneleri, `Concrete` klasörü somut nesneleri tutmaktadır.
`Abstarct` klasörü daha sonra geliştirilecek olan projeler içinde ortak kodlar içermesinden dolayı `Core` katmanına taşınmıştır.
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstarct`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: ~~IEntity~~<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Brand](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Brand.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Car](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Car.cs)<br>
### :file_folder: DataAccess Layer
### :file_folder: Business Layer
### :file_folder: Core Layer
