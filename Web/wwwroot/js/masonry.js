window.initMasonry = function () {
    var grid = document.querySelector('.masonry-container');
    var masonry = new Masonry(grid, {
        itemSelector: '.masonry-item',
        columnWidth: '.masonry-item',
        percentPosition: true
    });

    // Initialize lazy loading
    var lazyLoadInstance = new LazyLoad({
        elements_selector: ".thumbnail"
    });

    // Close modal when clicking outside
    window.addEventListener('click', function(event) {
        var modal = document.querySelector('.modal');
        if (event.target == modal) {
            closeModal();
        }
    });
};

function closeModal() {
    var modal = document.querySelector('.modal');
    modal.classList.remove('open');
}
