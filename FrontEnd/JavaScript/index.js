function handleShowDate(){
    const apiUrl = "https://localhost:5001/api/shows";

    fetch(apiUrl).then(function(response){
        return response.json();
    }).then(function(json){
        console.log(json);
        var dateUrl = json[0].year;
        var html = "<div id=\"date\">";
        json.forEach(dateUrl => {

            /*Logo.png is a place holder. Needs to be changed
            once database for songs is made */
            
            html += "<p><a href=\"./Logo.png\">" + dateUrl.year + "</a>";
        });
        html += "</p>";
        html += "</div>";
        document.getElementById("date").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}