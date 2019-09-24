import React from 'react'
import { Row, Col } from 'antd'
import 'antd/dist/antd.css'
import './style.css'

const Body = props => {
    return (
        <Row className="main" type="flex" justify="center">
            <Col className="main-left" xs={24} sm={24} md={16} lg={18} xl={14} >
                左侧内容
            </Col>
            <Col className="main-right" xs={0} sm={0} md={7} lg={5} xl={4}>
                右侧内容
            </Col>
        </Row>
    )
}

export default Body