# Traceability: Dağıtık Sistemlerde İzlenebilirlik

Traceability, bir dağıtık sistemde işlemlerin ve bileşenlerin gereksinimler doğrultusunda nasıl bir yol izlediğini ve bu tasarımın tüm unsurlarının takip edilebilirliğini ifade eder. Bu kavram sayesinde, sistem bileşenlerinin gereksinimlere uygun şekilde inşa edilip edilmediği anlaşılabilir ve değişikliklerin etkileri daha kolay analiz edilebilir.

💡 Traceability, bir işlemin yahut veri parçasının kaynağından hedefine kadar tüm aşamalarda geçtiği yolun takip edilmesi, gözlenmesidir.

Traceability sayesinde, distributed sistemdeki işlemler ve veriler tüm yaşam döngüsü boyunca kayıt altına alınarak, takip edilmekte ve doğrulanmaktadır. Bu süreçte, ilgili işlemlerin nerede başladığı, hangi bileşenler veya hizmetler üzerinden işlevler yürüttüğü ve nihai olarak hangi hedefe ulaştığı net bir şekilde belirlenebilmektedir.

## Traceability ve Log Arasındaki Farklar

|  | Traceability | Log |
| --- | --- | --- |
| Kapsam ve Amaç | Traceability, bir işlemin veya veri parçasının kaynağından hedefine kadar geçtiği yolun takip edilebilmesini sağlamak için kullanılan bir kavramdır. Amaç, işlemin veya verinin geçtiği bileşenleri, hizmetleri veya sistemleri izlemek ve takip etmektir. Genellikle; güvenlik, sorun giderme, uyumluluk ve performans analizi gibi amaçlarla kullanılmaktadır. | Loglar ise, bir sistemin veya uygulamanın faaliyetlerini kaydetmek için kullanılan kayıtlardır. Sistemde gerçekleşen olayları, hataları, uyarılan, kullanıcı etkileşimlerini ve diğer önemli bilgileri kaydetmek amacıyla oluşturulur. Loglar genellikle; sistem durumunu anlamak, sorunları tespit etmek, gidermek ve hataları izlemek için kullanılır. |
| İçerik | Traceability, genellikle bir işlemin veya veri parçasının geçtiği bileşenlerin yahut hizmetlerin tanımlandığı ilişkilendirme verilerini içerir. Bu veriler, işlemin kaynağı hedefi, ara bileşenler, kullanılan protokoller, zaman damgalan(timestamp) vb. gibi bilgileri içerebilir. Traceability, işlemin geçtiği yolun/sürecin izlenmesini sağlamak için kapsamlı bir bakış sunmaktadır. | Loglar ise, kaydedilen olayların ayrıntılarını içerir. Bu olaylar, işlemler, hatalar, uyanlar, kullanıcı etkileşimleri ve diğer önemli bilgiler olabilir. Loglar, sistemde gerçekleşen olayların ayrıntılı bir kaydını tutmakta ve belirli bir olayın gerçekleştiği zamana, içeriğe ve diğer ilgili verilere sahip olmayı sağlamaktadır. |
| Kullanım Amacı | Traceability'de sistemin genel işleyişini anlamak, verilerin kaynağından hedefine olan yolunu takip ederek/gözlemleyerek sistem performansını analiz etmek esastır. Bu yüzden genellikle; sistem tasarımı, güvenlik analizi, sorun giderme ve iyileştirme süreçlerinde hesaba katılır. | Loglar'da ki temel gaye ise sistemdeki olayları/davranışları kaydetmek ve sistemin çalışma sürecindeki hata ve uyanlar gibi reflekslerini tespit maksadıyla takip etmektir. Böylece loglar'daki temel amacın, sorunların izlenmesi ve giderilmesi olduğunu söyleyebiliriz. Log verileri sistem yöneticileri, geliştiriciler tarafından erişilebilir. Bu erişim neticesinde yorumlanarak sistem durumu, sorunları ve sistemin performansı hakkında bilgi edinilebilir. |

📌 Yani anlayacağınız; traceability, bir işlemin veya veri parçasının işleniş yolunu izlemek ve takip etmek söz konusuyken, logda ise sistemin veya uygulamanın faaliyetlerini kaydetmek ve sistem durumuyla ilgili bilgiler sağlamak temel gayedir. 

## Dağıtık Sistemlerde Traceability Bileşenleri

Traceability, yalnızca yazılımın kodsal parçalarıyla sınırlı değildir; yazılım projesinin daha geniş bir kapsamını ifade eder. Bu süreç şu bileşenlerden oluşur:

**1. Gereksinim İzlenebilirliği**: 
Sistem gereksinimlerinin izlenebilirliği, her bir gereksinimin sistemdeki bileşenlere nasıl dönüştüğünü göstermektedir. Böylece gereksinimlerin nasıl uygulandığı, değiştirildiği ve kaldırıldığı takip edilebilir.

**2. Tasarım İzlenebilirliği**: 
Tasarım izlenebilirliği ise gereksinimlerin nasıl bir tasarıma dönüştüğünü göstermektedir. Böylece de sistemdeki bileşenlerin birbirleriyle nasıl etkileşime girdiğini, veri akışını ve diğer sistem özelliklerini daha rahat anlamamızı sağlamaktadır.

**3. Kod İzlenebilirliği**: 
Kod izlenebilirliği ile de tasarımın nasıl uygulandığı takip edilebilmektedir. Bileşenin nasıl geliştirildiği. değiştirildiği ve hata düzeltmesinin nasıl yapıldığı takip edilebilir.

**4. Test İzlenebilirliği**: 
Bir bileşenin veya sistem özelliğinin nasıl test edildiğini gösterir. Bir test senaryosunun nasıl uygulandığını, sonuçlarının nasıl analiz edildiğini ve hataların nasıl düzeltildiğini takip etmemizi sağlar.

💡 Traceability bileşenleri bir bütün olarak değerlendirildiğinde, proje seviyesinde daha geniş bir izlenebilirlik sağlanır.

❗Traceability, sürekli olarak güncellenmesi ve takip edilmesi gereken bir süreçtir. Projeniz ilerledikçe yeni gereksinimler ortaya çıkabilir, tasarımlar ve kodlar değişebilir ve testlerin güncellenmesi gerekebilir. Bu nedenle, traceability'i proje yaşam döngüsü boyunca sürdürmek ve güncel tutmak önemlidir!

## Correlation ID Nedir?

Correlation ID adı üzerinde bir ilişkilendirme kimliğidir. Distributed sistemlerde farklı bileşenler arasındaki ilişkiyi takip etmek için kullanılan benzersiz bir tanımlayıcıdır. Bir işlem veya isteğin, başlangıcından sonuna kadar tüm sistemdeki bileşenler arasındaki ilişkiyi sürdürmek ve izlemek için kullanılmaktadır. Correlation ID genellikle bir isteğin veya işlemin başlatıldığı noktada oluşturulur ve tüm sistemde ilerledikçe geçişleri izlemek için kullanılır.

Correlation ID ile 3 farklı boyutta kod seviyesinde traceability'i uygulayabiliriz:

* **1. Metot Traceability'si**: 
Bir işlemin yapılabilmesi için hangi metotların işlevsellik gösterdiğinin metriğini sunan traceability'dir. 


* **2. Request/Response Traceability'si**: 
Yapılan request'e karşın response'un oluşturulması sürecine kadar arada tetiklenen kimi middleware'lerin ve yapılan işlemlerin metriğini sunan traceability'dir.


* **3. Message Broker Traceability'si**: 
Message Broker'in kullanıldığı distributed sistemlerde servisler arasında haberleşme sürecinde metrik sağlayan traceability'dir.



