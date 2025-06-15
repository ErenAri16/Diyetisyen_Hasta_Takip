# Diyetisyen Hasta Takip Sistemi

Bu proje, diyetisyenlerin hastalarını takip etmeleri için geliştirilmiş bir masaüstü uygulamasıdır.

## Özellikler

- Hasta yönetimi
- Öğün planı oluşturma ve takibi
- Besin veritabanı yönetimi
- İlerleme grafikleri ve raporlama
- Vücut kitle indeksi (VKİ) takibi
- Bel/Kalça oranı takibi

## Gereksinimler

- .NET Framework 4.7.2 veya üzeri
- SQL Server 2012 veya üzeri
- Windows işletim sistemi

## Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/kullaniciadi/diyetisyen-hasta-takip.git
```

2. Visual Studio'da projeyi açın

3. Veritabanını oluşturun:
   - SQL Server Management Studio'yu açın
   - `Database` klasöründeki `DiyetisyenHastaTakip.sql` dosyasını çalıştırın

4. Projeyi derleyin ve çalıştırın

## Kullanım

1. Uygulamayı başlatın
2. Giriş yapın (varsayılan kullanıcı: admin, şifre: admin)
3. Hasta ekleyin veya mevcut hastaları görüntüleyin
4. Hastalar için öğün planı oluşturun
5. İlerleme kayıtlarını tutun ve grafikleri görüntüleyin

## Katkıda Bulunma

1. Bu repository'yi fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/yeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/yeniOzellik`)
5. Pull Request oluşturun

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın. 