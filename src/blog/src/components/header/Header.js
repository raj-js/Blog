import React from 'react'
import { Row, Col, Menu, Icon } from 'antd'
import 'antd/dist/antd.css'
import './style.css'

const Header = props => {
    return (
        <Row className="header" type="flex" justify="center">
            <Col xs={24} sm={24} md={10} lg={10} xl={10}>
                <span className="header-logo">rajesh</span>
                <span className="header-signature">做到极致，便是大师</span>
            </Col>
            <Col xs={0} sm={0} md={14} lg={8} xl={6}>
                <Menu className="header-nav" defaultSelectedKeys="home" mode="horizontal">
                    <Menu.Item  className="header-nav-item" key="home">
                        <Icon type="home" />
                        文章
                    </Menu.Item>
                </Menu>
            </Col>
        </Row>
    )
}

export default Header