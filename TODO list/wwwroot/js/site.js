
const button = document.querySelector('#confetti-button');
const canvas = document.querySelector('#confetti');

const jsConfetti = new JSConfetti()

function shootConfettiAndSubmit(checkbox) {
    if (checkbox.checked) {
        jsConfetti.addConfetti({
            emojis: ['✅'],
            emojiSize: 40,
            confettiNumber: 20,

        });
        jsConfetti.addConfetti();
        setTimeout(() => {
            checkbox.form.submit(checkbox);
        }, 2000);
    }
    else {
        checkbox.form.submit(checkbox);
       
    }
    
    
    
    

}