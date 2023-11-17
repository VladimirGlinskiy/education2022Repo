let curDate = new Date;
let requestUrl = new URL('https://api.nasa.gov');


class RoverDates {
    roverName;
    landingDate;
    maxDate;

    setMaxDate(maximalDate) {
        if (maximalDate === null || maximalDate === undefined) {
            return curDate.getTime();
        } else {
            return new Date(maximalDate).getTime();
        }
    }

    constructor(roverName, landing_date, max_date) {
        this.roverName = roverName;
        this.landingDate = new Date(landing_date).getTime();
        this.maxDate = this.setMaxDate(max_date);
    }
}

let rovers = [new RoverDates("Spirit", "2004-01-04", "2010-03-21"),
    new RoverDates("Opportunity", "2004-01-25", "2018-06-11"),
    new RoverDates("Curiosity", "2012-08-06", null),
    new RoverDates("Perseverance", "2021-02-18", null)];


function getRoversList(dateOfPictures) {
    let roversList = [];
    let dateOfPicturesTime = new Date(dateOfPictures).getTime();

    for (let i = 0; i < rovers.length; i++) {
        if (dateOfPicturesTime >= rovers[i].landingDate && dateOfPicturesTime <= rovers[i].maxDate) {
            roversList.push(rovers[i].roverName);
        }
    }
    return roversList;
}

export {getRoversList}

function collectURLString(earth_date, page, api_key, roverName) {

    requestUrl.pathname = "/mars-photos/api/v1/rovers/" + roverName + "/photos";
    requestUrl.searchParams.set('earth_date', earth_date);
    requestUrl.searchParams.set('page', page);
    requestUrl.searchParams.set('api_key', api_key);
    console.log(requestUrl.toString());
    return requestUrl.toString();
}

export {collectURLString}