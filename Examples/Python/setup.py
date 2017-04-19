__author__ = 'farooq.sheikh'

from setuptools import setup, find_packages

setup(
    name = 'asposeemailcloudexamples',
    packages = find_packages(),
    version = '1.0.1',
    description = 'Aspose.Email Cloud SDK for Python allows you to use Aspose.Email APIs in your Python applications',
    author='Farooq Sheikh',
    author_email='farooq.sheikh@aspose.com',
    url='http://www.aspose.com/cloud/email-api.aspx',
    install_requires=[
        'asposestoragecloud','asposeemailcloud'
    ],    
    classifiers=[
        'Programming Language :: Python',
        'Programming Language :: Python :: 2',
        'License :: OSI Approved :: MIT License',
        'Operating System :: OS Independent'
    ]
)
