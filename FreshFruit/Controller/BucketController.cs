using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshFruit.Model;

namespace FreshFruit.Controller
{
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
                eventListener.onFailed("Ops, Keranjang Penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("Yey, Berhasil Ditambahkan");
            }
        }
        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }
        public void removeFruit(Fruit fruit)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems();
                itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.getName())
                {
                    bucket.remove(itemPosition);
                    eventListener.onSucceed("Yey, Berhasil Dihapus");
                }
            }
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
