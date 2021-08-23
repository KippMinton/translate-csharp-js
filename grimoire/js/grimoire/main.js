console.log("Do you believe in magic?")
console.log("------------------------")

let allSpells = [
  {
    Name: "Turn enemy into a newt",
    IsEvil: true,
    EnergyReqired: 5.1
  },
  {
    Name: "Conjure some gold for a local charity",
    IsEvil: false,
    EnergyReqired: 2.99
  },
  {
    Name: "Give a deaf person the ability to hear",
    IsEvil: false,
    EnergyReqired: 12.2
  },
  {
    Name: "Make yourself emperor of the universe",
    IsEvil: true,
    EnergyReqired: 100.0
  },
  {
    Name: "Convince your relatives your political views are correct",
    IsEvil: false,
    EnergyReqired: 2921.5
  }
]

// let goodSpells = allSpells.filter(spell => !spell.IsEvil)
// let evilSpells = allSpells.filter(spell => spell.IsEvil)

const makeEvilSpellBook = () => {
  let evilBook = {
    Title: "Evil Book",
    Spells: allSpells.filter(spell => spell.IsEvil)
  }

  return evilBook
}

const makeGoodSpellBook = () => {
  let goodBook = {
    Title: "Good Book",
    Spells: allSpells.filter(spell => !spell.IsEvil)
  }

  return goodBook
}

const displaySpellBook = (book) => {
  console.log(book.Title)
  for (const spell of book.Spells) {
    console.log(spell.Name)
  }
}

let goodBook = makeGoodSpellBook()
let evilBook = makeEvilSpellBook()

displaySpellBook(goodBook)
console.log("")
displaySpellBook(evilBook)