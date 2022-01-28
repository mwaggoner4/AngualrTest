
export interface Movie {
    filmId: number,
    filmName: string,
    filmRating: string,
    genre: string,
    filmDescription: string,
    filmDuration: number,
    imageUrl: string,
}


export interface Showtime {
    filmShowingsId: number,
    theatreId: number,
    filmId: number,
    showDate: Date,
    showTime: string,
    ticketsAvailable: number,
};

export interface Tickets {
    ticketType: string,
    ticketPrice: number,
}
export interface Customer {
    firstName: string,
    lastName: string,
}

export interface SelectionAmounts {
    option: number,
    amount: number,
}