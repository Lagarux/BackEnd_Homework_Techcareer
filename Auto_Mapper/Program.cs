using AutoMapper;

string explainAutoMapper = "AutoMapper, C# dilinde sıkça kullanılan bir nesne eşleme kütüphanesidir. " +
    "Bu kütüphane, bir sınıfın özelliklerini başka bir sınıfın özellikleriyle eşleme (haritalama) işlemini kolaylaştırmak için tasarlanmıştır." +
    " Genellikle, veritabanı nesneleriyle kullanıcı arayüzü nesneleri veya farklı katmanlardaki nesneler arasında veri transferi yaparken kullanılır.\r\n\r\nAutoMapper, tekrarlayan ve sıkıcı kod yazma ihtiyacını azaltmaya yardımcı olur." +
    " Bu, özellikle veritabanı tabloları ve iş mantığı sınıfları gibi birbirine benzeyen ancak farklı amaçlara hizmet eden sınıflar arasında geçiş yaparken kullanışlıdır.\r\n\r\nÖrneğin, bir veritabanı sınıfındaki bir özelliği, aynı adla veya farklı bir adla bir kullanıcı arayüzü sınıfındaki bir özellikle eşleştirmek istediğinizde AutoMapper, bu eşleştirmeyi otomatikleştirir.";

Console.WriteLine(explainAutoMapper);


// AutoMapper kullanımı
var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<EmployeeDb, EmployeeViewModel>()
        .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
});

IMapper mapper = config.CreateMapper();

// Eşleme
var employeeDb = new EmployeeDb { EmployeeId = 1, FirstName = "John", LastName = "Doe" };
var employeeViewModel = mapper.Map<EmployeeViewModel>(employeeDb);

public class EmployeeDb
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// Kullanıcı arayüzü sınıfı
public class EmployeeViewModel
{
    public int EmployeeId { get; set; }
    public string FullName { get; set; }
}




