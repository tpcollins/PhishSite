function handleShowDate(){
    const apiUrl = "https://localhost:5001/api/shows";

    fetch(apiUrl).then(function(response){
        return response.json();
    }).then(function(json){
        console.log(json);
        console.log(json)
        var dateUrl = json[0].year;
        var html = "<div id=\"date\">" + dateUrl;
        json.forEach(dateUrl => {
            html += " ";
            html += dateUrl.year;
        });
        html += "</div>";
        document.getElementById("date").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}