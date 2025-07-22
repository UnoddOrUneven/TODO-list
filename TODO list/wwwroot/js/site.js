
const button = document.querySelector('#confetti-button');
const canvas = document.querySelector('#confetti');

const jsConfetti = new JSConfetti()
button.addEventListener('click', () => {
    console.log("Clicked!");
    jsConfetti.addConfetti();
});

function shootConfettiAndSubmit(checkbox) {

    jsConfetti.addConfetti();
    
    setTimeout(() => {
        checkbox.form.submit(checkbox); 
    }, 2000);
    

}