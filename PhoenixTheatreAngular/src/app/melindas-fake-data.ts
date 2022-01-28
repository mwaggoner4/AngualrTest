import { Movie, SelectionAmounts, Showtime, Tickets } from './mytypes';

export const fakeMovie: Movie[] = [{
    filmId: 1,
    filmName: 'Faking It',
    filmRating: 'PG-13',
    genre: 'Fantasy',
    filmDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Non enim praesent elementum facilisis leo vel fringilla est. Auctor elit sed vulputate mi sit amet mauris commodo.',
    filmDuration: 101,
    imageUrl: 'https://images.unsplash.com/photo-1534447677768-be436bb09401?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8ZmFudGFzeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60'
},
{
    filmId: 2,
    filmName: 'Assassin With Wings',
    filmRating: 'R',
    genre: 'Adventure',
    filmDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Non enim praesent elementum facilisis leo vel fringilla est. Auctor elit sed vulputate mi sit amet mauris commodo.',
    filmDuration: 101,
    imageUrl: 'https://images.unsplash.com/photo-1643123237307-fbbc66a1a37d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=928&q=80'
},
{
    filmId: 3,
    filmName: 'Castle Without Hope',
    filmRating: 'PG-13',
    genre: 'Drama',
    filmDescription: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Non enim praesent elementum facilisis leo vel fringilla est. Auctor elit sed vulputate mi sit amet mauris commodo.',
    filmDuration: 120,
    imageUrl: 'https://images.unsplash.com/photo-1639485420052-dc3dfe222959?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8Y2FzbHRlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60'
},];

export const fakeTicketSelectionAmounts: SelectionAmounts[] = [
{
    option: 0,
    amount: 0
},
{
    option: 1,
    amount: 1
},
{
    option: 2,
    amount: 2
},
{
    option: 3,
    amount: 3
},
{
    option: 4,
    amount: 4
},{
    option: 5,
    amount: 5
}];

export const fakeTickets: Tickets[] = [
{
    ticketType: 'Children(ages 3-11)',
    ticketPrice: 7.75 
},
{
    ticketType: 'Adults (ages 12 & up)', 
    ticketPrice: 12.75
},
{
    ticketType: 'Seniors (ages 60+)',
    ticketPrice: 7.75
},
{
    ticketType: 'Military Discount (with valid ID)',
    ticketPrice: 7.75
},
{
    ticketType: 'Student Discount (with valid ID)',
    ticketPrice: 9.75
}];

export const fakeShowtime: Showtime[] = [{
    filmShowingsId: 1,
    theatreId: 1,
    filmId: 1,
    showDate: new Date(),
    showTime: '12:30p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 2,
    theatreId: 1,
    filmId: 1,
    showDate: new Date(),
    showTime: '1:00p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 3,
    theatreId: 1,
    filmId: 1,
    showDate: new Date(),
    showTime: '5:30p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 4,
    theatreId: 1,
    filmId: 2,
    showDate: new Date(),
    showTime: '12:30p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 5,
    theatreId: 1,
    filmId: 2,
    showDate: new Date(),
    showTime: '1:00p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 6,
    theatreId: 1,
    filmId: 2,
    showDate: new Date(),
    showTime: '5:30p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 7,
    theatreId: 1,
    filmId: 2,
    showDate: new Date(),
    showTime: '7:30p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 8,
    theatreId: 1,
    filmId: 3,
    showDate: new Date(),
    showTime: '7:30p',
    ticketsAvailable: 50
},
{
    filmShowingsId: 9,
    theatreId: 1,
    filmId: 3,
    showDate: new Date(),
    showTime: '8:30p',
    ticketsAvailable: 50
}];