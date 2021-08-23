console.log("Let's roll some dice, baby!")
console.log("---------------------------")

const roll = () => {
  min = Math.ceil(1)
  max = Math.floor(6)
  return Math.floor(Math.random() * (max - min + 1) + min);
}

for (let i=0; i < 10; i++) {
  let die1 = roll();
  let die2 = roll();

  let message = `${die1} + ${die2} = ${die1 + die2}`
  if (die1 == die2) {
    message += ` DOUBLES!`
  }
  
  console.log(message)
}
