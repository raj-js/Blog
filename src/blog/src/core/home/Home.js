import React, { memo } from 'react'
import Header from '../../components/header/Header'
import Body from '../../components/body/Body'

const Home = props => {
    return (
        <div>
            <Header></Header>
            <Body></Body>
        </div>
    )
}

export default memo(Home)