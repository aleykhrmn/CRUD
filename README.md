# Veritabanı Laboratuvarı Projesi

Bu repo, üniversitedeki veritabanı laboratuvarı dersi kapsamında geliştirilen bir uygulamayı içermektedir. Bu uygulama, Entity Framework, SQL Server ve C# kullanarak Code First yaklaşımı ile geliştirilmiştir. Uygulama, öğrenci, bölüm, fakülte ve ders bilgilerini yönetmek için çeşitli CRUD işlemleri ve listeleme işlevleri sunmaktadır.

## İstenilenler

### Veritabanı Tablo Yapıları
- **Öğrenci Tablosu:** `tOgrenci(ogrenciID, ad, soyad, bolumID)`
- **Bölüm Tablosu:** `tBolum(bolumID, bolumAd, fakulteID)`
- **Fakülte Tablosu:** `tFakulte(fakulteID, fakulteAd)`
- **ÖğrenciDers Tablosu:** `tOgrenciDers (ogrenciID, dersID, yil, yariyil, vize, final)`

### Geliştirme Detayları
- **Kullanılan Teknolojiler:** Entity Framework, SQL Server, C#
- **Yaklaşım:** Code First
- **Uygulama Türü:** Web tabanlı veya masaüstü (tercih size bırakıldı)

## Ekranlar ve İşlevler

### Ekran 1: Öğrenci Tablosu Üzerinde CRUD İşlemleri
- **Detaylar:** Öğrenci ekleme, güncelleme, silme ve listeleme işlemleri yapılmaktadır.
- **İlgili Tablo:** `tOgrenci`

### Ekran 2: Ders Tablosu Üzerinde CRUD İşlemleri
- **Detaylar:** Ders ekleme, güncelleme, silme ve listeleme işlemleri yapılmaktadır.
- **İlgili Tablo:** `tDers`

### Ekran 3: Bölüm Tablosu Üzerinde CRUD İşlemleri
- **Detaylar:** Bölüm ekleme, güncelleme, silme ve listeleme işlemleri yapılmaktadır.
- **İlgili Tablo:** `tBolum`

### Ekran 4: Öğrenciye Yıl ve Yarıyıl Seçimleri Yapılarak Ders Atama, Silme, Değiştirme İşlemleri
- **Detaylar:** Öğrenciye yıl ve yarıyıl seçimleri yapılarak ders atama, ders silme ve değiştirme işlemleri yapılmaktadır.
- **İlgili Tablo:** `tOgrenciDers`

### Ekran 5: Listeleme Ekranı
- **Öğrencinin Aldığı Dersleri Listeleme:**
  - **Detaylar:** Girilen öğrenci numarasına göre öğrencinin aldığı tüm dersleri listeleme.
- **Dersin Kaç Öğrenci Tarafından Seçildiğini Listeleme:**
  - **Detaylar:** Seçilen bir yıl ve yarıyıl bilgisine göre (örneğin, 2020-2021 Güz yarıyılı) hangi dersin kaç öğrenci tarafından seçildiğini listeleme.
- **İlgili Tablo:** `tOgrenciDers`

### Ekran 6: Ders Alan Öğrencilerin Listelenmesi ve Not Girme
- **Detaylar:** Seçilen bir dersi alan öğrencilerin listelenmesi, vize ve final notlarının girilerek kaydedilmesi.
- **İlgili Tablo:** `tOgrenciDers`

## Kurulum Talimatları

1. Depoyu klonlayın: `git clone https://github.com/kullaniciadi/repo-adi.git`
2. Proje dizinine gidin: `cd repo-adi`
3. Veritabanını kurun ve yapılandırın:
   - SQL Server'ı kurun ve gerekli bağlantı ayarlarını yapın.
   - Code First yaklaşımı ile veritabanı tablolarını oluşturmak için gerekli migrasyonları çalıştırın.
4. Uygulamayı çalıştırın:
   - Masaüstü uygulaması ise: Uygulama dosyasını çalıştırın.
