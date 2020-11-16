# Fresh Fruit
## Description
Program Fresh Fruit ini bertujuan untuk menambahkan item ke sebuah keranjang digital dan menghapus item dari keranjang.

## Scope of Functions
Berikut beberapa fungsi dari projek ini
- Menambahkan barang sampai 4 buah
- Penambahan fungsi delete pada program.
- Penambahan messagebox pada saat menambahkan dan menghapus.
- Ditambahkan messagebox image warning dan information.

## Apa fungsi dari BucketEventListener ?
Fungsi dari BucketEventListener adalah Sebagai tempat untuk handle event ketika action dijalankan berhasil (void `onSucceed`) atau gagal (void `onFailed`).
## Buatlah class Diagramnya !
![Class Diagram](ClassDiagram.png)
## Berilah pembahasan alur atau logika pemrogramannya !
Pembahasan logika pemrogramannya logika yg terdapat pada aplikasiini adalah untuk memasukan buah ke keranjang dan misal kalo keranjang penuh akan ada pemberitahuan keranjang penuh. syntax nya
```csharp
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }
        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("Yey, berhasil ditambahkan");
            }
        }
        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        public void RemoveFruit(Fruit fruit)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.name)
                {
                    bucket.remove(itemPosition);
                    eventListener.onSucceed("Yey, berhasil dihapus");
                }
            }
        }
```
## ITISHAM FAUZAN // 19.11.2804 