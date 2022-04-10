//Pobranie wpisanych danych w zamówieniu
function handleSubmit () {
    const street = document.getElementById('ulica').value;
    const city = document.getElementById('miasto').value;
    const postal = document.getElementById('pocztowy').value;
    const pizza = document.getElementById('pizza').value;
    const order = document.getElementById('zamow').value;

    sessionStorage.setItem("STREET", street);
    sessionStorage.setItem("CITY", city);
    sessionStorage.setItem("POSTAL", postal);
    sessionStorage.setItem("PIZZA", pizza);
    sessionStorage.setItem("ORDER", order);

    return;
}
