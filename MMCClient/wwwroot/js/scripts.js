window.addEventListener('DOMContentLoaded', event => {
    const listHoursContainer = document.querySelector('.list-hours');
    if (listHoursContainer) {
        const listHoursArray = listHoursContainer.querySelectorAll('li');
        const currentDay = new Date().getDay();

        if (listHoursArray.length > currentDay && listHoursArray[currentDay]) {
            listHoursArray[currentDay].classList.add('today');
        } else {
            console.error('No corresponding element for the current day or index out of bounds.');
        }
    } else {
        console.error('No .list-hours container found.');
    }
});
