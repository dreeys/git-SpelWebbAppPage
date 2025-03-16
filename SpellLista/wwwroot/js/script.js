document.addEventListener("DOMContentLoaded", function () {
    const gameCards = document.querySelectorAll(".game-card");
    const modal = document.getElementById("gameModal");
    const modalTitle = document.getElementById("modalTitle");
    const modalDescription = document.getElementById("modalDescription");
    const modalVideo = document.getElementById("modalVideo");
    const closeModal = document.querySelector(".close");

    // Open modal when clicking a game card
    gameCards.forEach(card => {
        card.addEventListener("click", function () {
            modalTitle.textContent = card.getAttribute("data-title");
            modalDescription.textContent = card.getAttribute("data-description");

            // Handle YouTube link formatting
            let videoUrl = card.getAttribute("data-video");
            if (videoUrl) {
                if (videoUrl.includes("watch?v=")) {
                    videoUrl = videoUrl.split("watch?v=")[1].split('&')[0];
                    videoUrl = `https://www.youtube.com/embed/${videoUrl}`;
                } else if (videoUrl.includes("youtu.be/")) {
                    videoUrl = videoUrl.split("youtu.be/")[1].split('?')[0];
                    videoUrl = `https://www.youtube.com/embed/${videoUrl}`;
                }
                modalVideo.src = videoUrl;
            } else {
                modalVideo.src = ""; // If no video, leave empty
            }

            modal.style.display = "flex";
        });
    });

    // Close modal when clicking on X
    closeModal.addEventListener("click", function () {
        modal.style.display = "none";
        modalVideo.src = ""; // Stop video when closing modal
    });

    // Close modal when clicking outside the modal-content
    window.addEventListener("click", function (e) {
        if (e.target === modal) {
            modal.style.display = "none";
            modalVideo.src = "";
        }
    });
});
