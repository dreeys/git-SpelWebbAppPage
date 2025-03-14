
//Tagen från förra asp.net uppgfiten FILMFOKUS

document.addEventListener("DOMContentLoaded", function () {
    const categorySelect = document.getElementById("categorySelect");
    const gameCards = document.querySelectorAll(".game-card");

    categorySelect.addEventListener("change", function () {
        const selectedCategory = categorySelect.value;

        gameCards.forEach(card => {
            if (selectedCategory === "Alla" || card.dataset.category === selectedCategory) {
                card.style.display = "block";
            } else {
                card.style.display = "none";
            }
        });
    });
});
