using System;
using System.Collections;
class program{
static void Main(string[] args){a1:

System.Console.WriteLine("Lütfen, işlem yapmak istediğiniz şekli seçiniz:");
System.Console.WriteLine("Daire (1) Üçgen (2) Kare (3) Dikdörtgen (4) GoldenSHOT!!! (5)");
Int32 x =Int32.Parse(Console.ReadLine());
switch(x){
case 1:Daire();     goto a1;
case 2:Ucgen();     goto a1;
case 3:Kare();      goto a1;
case 4:Dikdörtgen();goto a1;
case 5:System.Console.WriteLine("Lütfen tek bir sayı giriniz:");
Int32 h =Int32.Parse(Console.ReadLine());
GoldenShot(h);goto a1;
}

void Daire(){
System.Console.WriteLine("Lütfen yarıçapı belirtiniz:"); //r
Int32 y =Int32.Parse(Console.ReadLine());
System.Console.WriteLine(" Yaricap: "+y+"\nDairenin Alanı: {0} \n Daireinin Çevresi: {1}",y*y*Math.PI, 2*Math.PI*y);
}

void Ucgen(){a2:
System.Console.WriteLine("Lütfen sırası ile, yükseklik, taban kenar uzunluğu, sol kenar uzunluğu, sağ kenar uzunluğu giriniz:");//a,b,c,d
Int32 a =Int32.Parse(Console.ReadLine());
Int32 b =Int32.Parse(Console.ReadLine());
Int32 c =Int32.Parse(Console.ReadLine());
Int32 d =Int32.Parse(Console.ReadLine());if(a>=d||a>=c||a>=b){System.Console.WriteLine("Yükseklik, diğer verilerden büyük ya da eşit olamaz! Tekrar deneyiniz.");goto a2;}
System.Console.WriteLine("Yükselik: "+a+" Taban Kenar Uzunluğu: "+b+" Sol Kenar Uzunluğu: "+c+" Sağ Kenar Uzunluğu: "+d+"\nÜçgenin Alan: {0} \n Üçgenin Çevresi: {1}",a*b/2, b+c+d);
}

void Kare(){
System.Console.WriteLine("Lütfen bir kenar uzunluğu giriniz:");//e
Int32 e =Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Kenar Uzunluğu: "+e+"\nKarenin Alanı: {0} \n Karenin Çevresi: {1}",e*e,4*e);
}

void Dikdörtgen(){a3:
System.Console.WriteLine("Lütfen sırasıyla kısa ve uzun kenar giriniz:");//f,g
Int32 f =Int32.Parse(Console.ReadLine());
Int32 g =Int32.Parse(Console.ReadLine()); if(f>=g){System.Console.WriteLine("Kısa Kenar, Uzun Kenardan uzun ya da eşit olamaz! Tekrar Deneyin.");goto a3;}
System.Console.WriteLine("Kısa Kenar: "+f+" Uzun Kenar: "+g+"\nDikdörtgenin Alanı: {0} \n Dikdörtgenin Çevresi: {1}", f*g , 2*(f+g));
}

static void GoldenShot(int h){
System.Console.WriteLine(" Yaricap: "+h+"\nDairenin Alanı: {0} \n Daireinin Çevresi: {1}",h*h*Math.PI, 2*Math.PI*h);
System.Console.WriteLine("######################");
System.Console.WriteLine("Yükselik: "+h*Math.Sqrt(3)/2+" Taban Kenar Uzunluğu: "+h+" Sol Kenar Uzunluğu: "+h+" Sağ Kenar Uzunluğu: "+h+"\nÜçgenin Alan: {0} \n Üçgenin Çevresi: {1}",h*h*Math.Sqrt(3)/2, h+h+h);
System.Console.WriteLine("######################");
System.Console.WriteLine("Kenar Uzunluğu: "+h+"\n Karenin Çevresi: {1}",h*h,4*h);
System.Console.WriteLine("######################");
System.Console.WriteLine("Kısa Kenar: "+h+" Uzun Kenar: "+2*h+"\n Dikdörtgenin Çevresi: {1}", h*h , 2*(h+2*h));
}}}
