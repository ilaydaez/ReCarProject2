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
Üç alt klasörden oluşmaktadır. <br>
&nbsp;&nbsp;1.`Abstarct` klasörü soyut nesneleri tutmak için (`Abstarct` klasörü daha sonra geliştirilecek olan projeler içinde ortak kodlar içermesinden dolayı `Core` katmanına taşınmıştır.),<br>
&nbsp;&nbsp;2.`Concrete` klasörü somut nesneleri tutmak için <br>
&nbsp;&nbsp;3.`DTOs` klasörü nesnelere farklı özellikler vermek ve veritabanındaki tabloları birleştirmek için kullanılmıştır.
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstarct`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: ~~IEntity~~<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Brand](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Brand.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Car](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Car.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Color](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Color.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Customer](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Customer.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Image](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Image.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Rental](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/Concrete/Rental.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `DTOs`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarDetailsDto](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/DTOs/CarDetailsDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [RentalDetailsDto](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/DTOs/RentalDetailsDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserForLoginDto](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/DTOs/UserForLoginDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserForRegisterDto](https://github.com/ilaydaez/ReCarProject2/blob/master/Entitie/DTOs/UserForRegisterDto.cs)<br>

### :file_folder: DataAccess Layer
Veritabanı CRUD işlemleri gerçekleştirmek için kurulan veri erişim katmanıdır.<br>
İki alt klasörden oluşmaktadır.<br>
&nbsp;&nbsp;1.`Abstarct` klasörü soyut nesneleri tutmak için,<br>
&nbsp;&nbsp;2.`Concrete` klasörü somut nesneleri tutmak için. <br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstarct`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IBrandDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/IBrandDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICarDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/ICarDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IColorDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/IColorDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICustomerDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/ICustomerDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IImageDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/IImageDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IRentalDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/IRentalDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IUserDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Abstract/IUserDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `EntityFrameWork`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfBrandDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfCarDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfColorDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfCustomerDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfImageDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfImageDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfRentalDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfUserDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ReCarContext](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/EntityFramework/ReCarContext.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `InMemory`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [InMemoryDal](https://github.com/ilaydaez/ReCarProject2/blob/master/DataAccess/Concrete/InMemory/InMemoryDal.cs)<br>

### :file_folder: Business Layer
DataAccess tarafından veratabanından projeye çekilen verileri alarak işleyen katmandır. Bir başka deyişle iş yüklerinin yazıldığı katmandır.
Altı alt klasörden oluşur.<br>
&nbsp;&nbsp;1.`Abstarct` klasörü soyut nesneleri tutmak için,<br>
&nbsp;&nbsp;2.`Concrete` klasörü somut nesneleri tutmak için,<br>
&nbsp;&nbsp;3.`BusinessAspect` klasörü güvenlik operasyonlarının yönetimi için,<br>
&nbsp;&nbsp;4.`Constants` klasörü kullanıcı verileri ile gerçekleştirilen işlem sonucunda bilgilendirme mesajlarının yönetimi için, <br>
&nbsp;&nbsp;5.`DependecyResolvers` klasörü,<br>
&nbsp;&nbsp;6.`ValidationRules` klasörü doğrulama kurallarının yönetimi için oluşturuluştur.<br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstarct`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IAuthService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/IAuthService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IBrandService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/IBrandService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICarService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/ICarService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IColorService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/IColorService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICustomerService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/ICustomerService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IImageService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/IImageService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IRentalService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/IRentalService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IUserService](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Abstract/IUserService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AuthManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/AuthManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [BrandManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/BrandManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/CarManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ColorManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/ColorManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CustomerManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/CustomerManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ImageManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/ImageManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [RentalManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/RentalManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserManager](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Concrete/UserManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`BusinessAspect`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SecuredOperation](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/BusinessAspect/Autofac/SecuredOperation.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Constants`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Messages](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Constants/Messages.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DependecyResolvers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AutofacBusinessModule](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/DependecyResolvers/Autofac/AutofacBusinessModule.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`ValidationRules`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `FluentValidation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [BrandValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ColorValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CustomerValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ImageValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/ImageValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [RentalValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserValidator](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs)<br>


### :file_folder: Core Layer
Tüm projelerde kullanılacak ortak kodların bulunduğu evrensel bir katmandır.
Yedi alt klasörden oluşmaktadır.
&nbsp;&nbsp;1.`Aspects` klasörü,<br>
&nbsp;&nbsp;2.`CrossCuttingConcerns` klasörü,<br>
&nbsp;&nbsp;3.`DataAccess` klasörü,<br>
&nbsp;&nbsp;4.`Entities` klasörü, <br>
&nbsp;&nbsp;5.`DependecyResolvers` klasörü instance oluşturmak için,<br>
&nbsp;&nbsp;6.`Extensions` klasörü,<br>
&nbsp;&nbsp;7.`Utilities` klasörü,<br>


