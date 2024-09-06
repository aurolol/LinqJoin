Pratik - LINQ Join

Bir kütüphane yönetim sistemi oluşturun. Bu sistemde iki adet tablo bulunmaktadır: Yazarlar ve Kitaplar. Aşağıda her iki tablonun yapısı verilmektedir:

Yazarlar Tablosu (Authors)

AuthorId (int) : Yazarın benzersiz kimliği
Name (string) : Yazarın adı
Kitaplar Tablosu (Books)

BookId (int) : Kitabın benzersiz kimliği
Title (string) : Kitabın başlığı
AuthorId (int) : Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkili)
Görev:
Tabloların Tanımlanması:
Author ve Book adında iki sınıf oluşturun ve yukarıdaki tablo yapıları bu sınıflara uygun şekilde tanımlayın.

Verilerin Eklenmesi:
Her iki tabloya da örnek veriler ekleyin. En az 3 yazar ve 4 kitap ekleyin.

LINQ Sorgusu Yazılması:
Kitapların ve yazarların birleştirildiği bir LINQ sorgusu oluşturun. Bu sorgu, her kitabın başlığını ve yazarıyla olan ilişkisini içermelidir.

Sonuçların Yazdırılması:
Oluşturduğunuz LINQ sorgusunun sonucunu ekrana yazdırın. Her kitabın başlığı ve yazarın adını içeren bilgileri gösteren bir çıktı sağlıyoruz.

- with c#
