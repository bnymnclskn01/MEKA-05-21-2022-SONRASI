function Hesapla() {
	var k1=Number(document.getElementById("txtKenar1").value);
	var k2=Number(document.getElementById("txtKenar2").value);
	var hupo=Math.sqrt((k1*k1)+(k2*k2));
	document.getElementById("sonuc").innerHTML="Hipotenüs : "+hupo;
}
var hesapBtn=document.getElementById("btn");
hesapBtn.onclick=Hesapla;