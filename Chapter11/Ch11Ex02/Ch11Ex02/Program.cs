
using Ch11Ex01;
using Ch11Ex02;

AnimalCollection animalCollection = new AnimalCollection();
animalCollection.Add(new Chicken("Dona"));
animalCollection.Add(new Chicken("Mary"));
foreach (Animal myAnimal in animalCollection)
{
    myAnimal.Feed();
}
animalCollection[1] = new Chicken("Noa");

foreach (Animal myAnimal in animalCollection)
{
    myAnimal.Feed();
}

Chicken donna = (Chicken)animalCollection[0];
donna.LayEgg();

//This is alternative way
((Chicken)animalCollection[0]).LayEgg();