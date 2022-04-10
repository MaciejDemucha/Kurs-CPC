//Przekazanie danych z zamówienia na stronę podsumowania
window.addEventListener('load', () => {

    const street = sessionStorage.getItem('STREET');
    const city = sessionStorage.getItem('CITY');
    const postal = sessionStorage.getItem('POSTAL');
    const pizza = sessionStorage.getItem('PIZZA');
    const order = sessionStorage.getItem('ORDER');

    document.getElementById('result-street').innerHTML = street;
    document.getElementById('result-city').innerHTML = city;
    document.getElementById('result-postal').innerHTML = postal;
    document.getElementById('result-pizza').innerHTML = pizza;
    document.getElementById('result-order').innerHTML = order;

})

//Wyświetlenie komunikatu i powrót do strony głownej po 5 s od naciśnięcia przycisku

document.getElementById("go-button").addEventListener("click", addNotification);

function addNotification(){
  var add = document.createElement("div");
  var parent = document.getElementById("notification").parentNode;
  var where = document.getElementById("notification");
  add.innerHTML = "<p></br><center>Za 5 sekund nastąpi automatyczne przekierowanie na stronę główną...</center></p>";
  parent.insertBefore(add, where);
  setTimeout(function(){ window.location.href = "../index.html"; }, 5000);
}
