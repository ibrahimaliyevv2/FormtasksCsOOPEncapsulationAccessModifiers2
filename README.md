# FormtasksCsOOPEncapsulationAccessModifiers2


Task-1:

Ashagidaki 2 classi yaradirsiz.    
    User class:
               Username
               Password


```Admin class:
               IsSuperAdmin (boolean type)
               Section (adminin web saytda idare etdiyi hisse)


User classi base class, admin classi ise  miras alir.
Username ve password sensitive datalardir (encapsulation olunmalidir). Ipucu: access modifier


Bir admin yaradildigi zaman username, password, isSuperadmin ve section memberleri avtomatik teyin olunmalidir (en optimal variantda yazirsiz),
her hansi bir member datasi teyin olunmamis admin obyekti yaradila bilmez.


Username set olundugu zaman uzunlugu 6-dan boyuk olmalidir. Password set olundugu zaman icerisinde minimum 1 eded olmalidir ve minimum 1 herfi boyuk olmalidir.

Console Application run olundugu zaman admin username ve passwordunu daxil edir. Eger daxil olunan deyer Username memberinin sertlerini odemirse
istifadeciden yeniden username-ni daxil etmesi teleb olunmalidir. Eyni qaydada daxil olunan deyer Password memberinin sertlerini odemirse istifadeciden
yeniden password-u daxil etmesi teleb olunmalidir. Eger her sey duzgundurse console-da IsSuperAdmin ve Section deyerleri qeyd olunur ve admin datasi yaranir.
En sonda adminin butun datalarini geriye qaytaran
bir method-u cagiraraq ekranda Adminin datalarini yazdirirsiz ve application bitir.
