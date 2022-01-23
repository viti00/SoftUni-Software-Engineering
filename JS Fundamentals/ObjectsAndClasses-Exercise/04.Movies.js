function movies(arr){
debugger;
    let movies = [];

    class Movie{
        constructor(name, date, director){
            this.name = name;
            this.date = date;
            this.director = director;
        }
    }

    for (let i = 0; i < arr.length; i++) {
        
        let curr = arr[i];
        let splitted = curr.split(" ");

        if (curr.includes("addMovie")){
            let name = splitted.slice(1, splitted.length).join(" ");
            movies.push(new Movie(name, null, null));
        }
        else if (curr.includes("onDate")){ 
            let index = splitted.indexOf("onDate");
            let nameOfMovie = splitted.slice(0, index).join(" ");

            if (containse(nameOfMovie) != undefined){
                let movie = containse(nameOfMovie);
                movie.date = splitted.slice(index + 1, splitted.length).toString();
            }

        }
        else if (curr.includes("directedBy")){
            let indx = splitted.indexOf("directedBy");
            let movieName = splitted.slice(0, indx).join(" ");

           if (containse(movieName) != undefined){
               let movie = containse(movieName);
               movie.director = splitted.slice(indx + 1, splitted.length).join(" ");
           }
        }
    }
    movies.forEach(m => m.director != null && m.name != null && m.date != null ? console.log(JSON.stringify(m)) : null);

    function containse(movieName){
        let movie = movies.find(m=> m.name == movieName);
        return movie;
    }
}

movies([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
    ]);