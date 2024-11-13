# Kitap ve Yazarlar Projesi

Bu proje, kitaplar ve yazarlar arasındaki ilişkiyi temsil eden basit bir konsol uygulamasıdır. C# dilinde yazılmış olan bu uygulama, LINQ kullanarak kitaplar ve yazarlar listesi arasında ilişki kurar ve eşleşen yazarları, kitapların başlıkları ile birlikte konsola yazdırır.

## Dosya Yapısı

- **Authors**: Yazarları temsil eden sınıf. Her yazarın benzersiz bir `AuthorId` kimliği ve bir `AuthorName` (yazar adı) özelliği bulunmaktadır.
- **Books**: Kitapları temsil eden sınıf. Her kitabın benzersiz bir `BookId` kimliği, `Title` (kitap başlığı) ve `AuthorId` (yazar kimliği) özelliği bulunmaktadır.
- **Program**: Ana sınıf, kitap ve yazarların bir listesini oluşturur ve LINQ `Join` işlemi ile kitap ve yazarlar arasındaki ilişkileri eşleştirir.

## Kodun Çalıştırılması

1. **Kitaplar Listesi**: `Books` sınıfından oluşturulan bir liste, her kitabın `BookId`, `Title` ve `AuthorId` özelliklerini içerir.
2. **Yazarlar Listesi**: `Authors` sınıfından oluşturulan bir liste, her yazarın `AuthorName` ve `AuthorId` özelliklerini içerir.
3. **LINQ Kullanarak İlişkilendirme**: `Join` işlemi kullanılarak kitapların `AuthorId` özelliği ile yazarların `AuthorId` özelliği eşleştirilir. Eşleşen sonuçlar `booksAuthors` adlı bir koleksiyonda tutulur.
4. **Konsola Yazdırma**: Her kitap ve yazar eşleştirmesi, kitap başlığı ve yazar adıyla birlikte konsola yazdırılır.

## Örnek Çıktı

```plaintext
Kitabın başlığı: Bir Genç Kızın Günlüğü, Yazarın adı: İpek Ongun
Kitabın başlığı: Kürk Mantolu Madonna, Yazarın adı: Sabahattin Ali
Kitabın başlığı: Seyir, Yazarın adı: Piraye
