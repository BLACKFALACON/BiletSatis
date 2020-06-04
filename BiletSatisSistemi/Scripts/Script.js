

function arttir()
{
    var sonuc = document.getElementById("sonuc");
     sonuc.value = Number(sonuc.value) + 1;
}

function azalt() {
    var sonuc = document.getElementById("sonuc");
    if (Number(sonuc.value)>0)
    {
        sonuc.value = Number(sonuc.value) - 1;
    }
    
   
}

function openNav()
{
    document.getElementById("myNav").style.display = "block";
}

function closeNav()
{
   document.getElementById("myNav").style.display = "none";
}

function kapa()
{
  document.getElementsByClassName("panel").style.display = "none";
}

