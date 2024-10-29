import { useState, useEffect } from 'react'

interface MyObjectWithImage {
    imageUrls: string
    title: string
}

function App() {
const [objectWithImage, setObjectWithImage] = useState<MyObjectWithImage | null>(null)

  return (
    <>

    </>
  )
}

export default App
