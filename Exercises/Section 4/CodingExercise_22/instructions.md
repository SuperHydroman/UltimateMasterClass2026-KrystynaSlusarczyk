## Inheritance & Overriding - Animals
In the code, you will see the **GetCountsOfAnimalsLegs** method. It iterates a List of **Animals** containing a **Lion**, a **Tiger**, a **Duck**, and a **Spider**.

This List is iterated, and the NumberOfLegs of each animal is added to the **result** List, which is then returned from this method.

**Your job is to define the following classes:**
* Animal (base class)
* Lion (derived from Animal)
* Tiger (derived from Animal)
* Duck (derived from Animal)
* Spider (derived from Animal)

**...in such a way that the result List will contain the following numbers:**
* 4 (Lion)
* 4 (Tiger)
* 2 (Duck)
* 8 (Spider)

Since we have two animals that have 4 legs, consider setting the **NumberOfLegs in the base class to 4** and only **override** it in classes representing Animals with different numbers of legs.